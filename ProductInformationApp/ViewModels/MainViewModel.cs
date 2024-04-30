using BarcodeScanning;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ProductInformationApp.Models;
using ProductInformationApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ProductInformationApp.ViewModels {
    public partial class MainViewModel : ObservableObject {
        public MainViewModel(HttpClient httpClient) {
            this.httpClient = httpClient;
        }
        private readonly string baseUrl = "https://world.openfoodfacts.org/api/v0/product/{0}.json";

        [ObservableProperty]
        private bool isLoading = false;
        [ObservableProperty]
        private string codeInput = string.Empty;

        [ObservableProperty]
        private bool cameraOpen = false;
        private readonly HttpClient httpClient;

        [ObservableProperty]
        private Product product;


        [RelayCommand]
        private async Task Search() {
            if (string.IsNullOrWhiteSpace(CodeInput)) {
                return;
            }
            if(IsLoading == true) {
                return;
            }
            IsLoading = true;
            try {
                var result = await httpClient.GetFromJsonAsync<ProductResponse>(string.Format(baseUrl, CodeInput));
                if (result != null && result.status == 1) {
                    Product = result.product;
                    await Shell.Current.GoToAsync("product");
                }else {
                    Toast.Make("Product not found!",ToastDuration.Short).Show();
                }
            } catch (Exception ex) {
                Toast.Make("Network Error!", ToastDuration.Short).Show();
            }
            IsLoading = false;
        }

        [RelayCommand]
        private void DetectionFinished(BarcodeResult[] scanResult) {
            if (scanResult.Length > 0) {
                CodeInput = scanResult[0].DisplayValue;
                CameraOpen = false;
                _ = Search();
            }
        }

        [RelayCommand]
        private void OpenCamera() {
            CameraOpen = true;
        }
        [RelayCommand]
        private void CloseCamera() {
            CameraOpen = false;
        }

    }
}
