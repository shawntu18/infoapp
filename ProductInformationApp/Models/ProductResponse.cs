using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductInformationApp.Models {
    public class ProductResponse {
        public string code { get; set; }
        public Product product { get; set; }
        public int status { get; set; }
        public string status_verbose { get; set; }
    }

    public class Product {
        public string _id { get; set; }
        public string[] _keywords { get; set; }
        public object[] added_countries_tags { get; set; }
        public string[] additives_debug_tags { get; set; }
        public int additives_n { get; set; }
        public int additives_old_n { get; set; }
        public object[] additives_old_tags { get; set; }
        public string[] additives_original_tags { get; set; }
        public string[] additives_prev_original_tags { get; set; }
        public string[] additives_tags { get; set; }
        public string allergens { get; set; }
        public string allergens_from_ingredients { get; set; }
        public string allergens_from_user { get; set; }
        public object[] allergens_hierarchy { get; set; }
        public object[] allergens_tags { get; set; }
        public object[] amino_acids_prev_tags { get; set; }
        public object[] amino_acids_tags { get; set; }
        public string brand_owner { get; set; }
        public string brand_owner_imported { get; set; }
        public string brands { get; set; }
        public string[] brands_tags { get; set; }
        public string categories { get; set; }
        public string[] categories_hierarchy { get; set; }
        public string categories_imported { get; set; }
        public string categories_lc { get; set; }
        public string categories_old { get; set; }
        public Categories_Properties categories_properties { get; set; }
        public string[] categories_properties_tags { get; set; }
        public string[] categories_tags { get; set; }
        public Category_Properties category_properties { get; set; }
        public object[] checkers_tags { get; set; }
        public string[] ciqual_food_name_tags { get; set; }
        public object[] cities_tags { get; set; }
        public string code { get; set; }
        public string[] codes_tags { get; set; }
        public string compared_to_category { get; set; }
        public int complete { get; set; }
        public float completeness { get; set; }
        public string[] correctors_tags { get; set; }
        public string countries { get; set; }
        public string[] countries_hierarchy { get; set; }
        public string countries_imported { get; set; }
        public string countries_lc { get; set; }
        public string[] countries_tags { get; set; }
        public int created_t { get; set; }
        public string creator { get; set; }
        public object[] data_quality_bugs_tags { get; set; }
        public object[] data_quality_errors_tags { get; set; }
        public string[] data_quality_info_tags { get; set; }
        public string[] data_quality_tags { get; set; }
        public string[] data_quality_warnings_tags { get; set; }
        public string data_sources { get; set; }
        public string data_sources_imported { get; set; }
        public string[] data_sources_tags { get; set; }
        public string[] debug_param_sorted_langs { get; set; }
        public Ecoscore_Data ecoscore_data { get; set; }
        public string ecoscore_grade { get; set; }
        public string[] ecoscore_tags { get; set; }
        public string[] editors_tags { get; set; }
        public string emb_codes { get; set; }
        public object[] emb_codes_debug_tags { get; set; }
        public string emb_codes_orig { get; set; }
        public object[] emb_codes_tags { get; set; }
        public string[] entry_dates_tags { get; set; }
        public string expiration_date { get; set; }
        public object[] expiration_date_debug_tags { get; set; }
        public string food_groups { get; set; }
        public string[] food_groups_tags { get; set; }
        public Forest_Footprint_Data forest_footprint_data { get; set; }
        public string generic_name { get; set; }
        public string generic_name_fr { get; set; }
        public object[] generic_name_fr_debug_tags { get; set; }
        public string id { get; set; }
        public string image_front_small_url { get; set; }
        public string image_front_thumb_url { get; set; }
        public string image_front_url { get; set; }
        public string image_small_url { get; set; }
        public string image_thumb_url { get; set; }
        public string image_url { get; set; }
        public Images images { get; set; }
        public string[] informers_tags { get; set; }
        public Ingredient1[] ingredients { get; set; }
        public Ingredients_Analysis ingredients_analysis { get; set; }
        public string[] ingredients_analysis_tags { get; set; }
        public int ingredients_from_or_that_may_be_from_palm_oil_n { get; set; }
        public int ingredients_from_palm_oil_n { get; set; }
        public object[] ingredients_from_palm_oil_tags { get; set; }
        public string[] ingredients_hierarchy { get; set; }
        public int ingredients_n { get; set; }
        public string[] ingredients_n_tags { get; set; }
        public string[] ingredients_original_tags { get; set; }
        public int ingredients_percent_analysis { get; set; }
        public string[] ingredients_tags { get; set; }
        public string ingredients_text { get; set; }
        public string ingredients_text_debug { get; set; }
        public object[] ingredients_text_debug_tags { get; set; }
        public string ingredients_text_en { get; set; }
        public string ingredients_text_en_imported { get; set; }
        public string ingredients_text_fr { get; set; }
        public object[] ingredients_text_fr_debug_tags { get; set; }
        public string ingredients_text_with_allergens { get; set; }
        public string ingredients_text_with_allergens_en { get; set; }
        public string ingredients_text_with_allergens_fr { get; set; }
        public int ingredients_that_may_be_from_palm_oil_n { get; set; }
        public object[] ingredients_that_may_be_from_palm_oil_tags { get; set; }
        public int ingredients_with_specified_percent_n { get; set; }
        public int ingredients_with_specified_percent_sum { get; set; }
        public int ingredients_with_unspecified_percent_n { get; set; }
        public int ingredients_with_unspecified_percent_sum { get; set; }
        public string[] ingredients_without_ciqual_codes { get; set; }
        public int ingredients_without_ciqual_codes_n { get; set; }
        public string interface_version_created { get; set; }
        public string interface_version_modified { get; set; }
        public int known_ingredients_n { get; set; }
        public string labels { get; set; }
        public string[] labels_hierarchy { get; set; }
        public string labels_lc { get; set; }
        public string labels_old { get; set; }
        public string[] labels_tags { get; set; }
        public string lang { get; set; }
        public Languages languages { get; set; }
        public Languages_Codes languages_codes { get; set; }
        public string[] languages_hierarchy { get; set; }
        public string[] languages_tags { get; set; }
        public string[] last_edit_dates_tags { get; set; }
        public string last_editor { get; set; }
        public string[] last_image_dates_tags { get; set; }
        public int last_image_t { get; set; }
        public string last_modified_by { get; set; }
        public int last_modified_t { get; set; }
        public int last_updated_t { get; set; }
        public string lc { get; set; }
        public string lc_imported { get; set; }
        public string link { get; set; }
        public object[] link_debug_tags { get; set; }
        public object[] main_countries_tags { get; set; }
        public string manufacturing_places { get; set; }
        public object[] manufacturing_places_debug_tags { get; set; }
        public object[] manufacturing_places_tags { get; set; }
        public string max_imgid { get; set; }
        public object[] minerals_prev_tags { get; set; }
        public string[] minerals_tags { get; set; }
        public string[] misc_tags { get; set; }
        public string no_nutrition_data { get; set; }
        public int nova_group { get; set; }
        public string nova_group_debug { get; set; }
        public string nova_groups { get; set; }
        public Nova_Groups_Markers nova_groups_markers { get; set; }
        public string[] nova_groups_tags { get; set; }
        public object[] nucleotides_prev_tags { get; set; }
        public object[] nucleotides_tags { get; set; }
        public Nutrient_Levels nutrient_levels { get; set; }
        public string[] nutrient_levels_tags { get; set; }
        public Nutriments nutriments { get; set; }
        public Nutriscore nutriscore { get; set; }
        public string[] nutriscore_2021_tags { get; set; }
        public string[] nutriscore_2023_tags { get; set; }
        public Nutriscore_Data nutriscore_data { get; set; }
        public string nutriscore_grade { get; set; }
        public int nutriscore_score { get; set; }
        public int nutriscore_score_opposite { get; set; }
        public string[] nutriscore_tags { get; set; }
        public string nutriscore_version { get; set; }
        public string nutrition_data { get; set; }
        public string nutrition_data_per { get; set; }
        public object[] nutrition_data_per_debug_tags { get; set; }
        public string nutrition_data_per_imported { get; set; }
        public string nutrition_data_prepared_per { get; set; }
        public string nutrition_data_prepared_per_imported { get; set; }
        public string nutrition_grade_fr { get; set; }
        public string nutrition_grades { get; set; }
        public string[] nutrition_grades_tags { get; set; }
        public int nutrition_score_beverage { get; set; }
        public string nutrition_score_debug { get; set; }
        public int nutrition_score_warning_fruits_vegetables_legumes_estimate_from_ingredients { get; set; }
        public int nutrition_score_warning_fruits_vegetables_legumes_estimate_from_ingredients_value { get; set; }
        public int nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients { get; set; }
        public int nutrition_score_warning_fruits_vegetables_nuts_estimate_from_ingredients_value { get; set; }
        public string origins { get; set; }
        public object[] origins_hierarchy { get; set; }
        public string origins_lc { get; set; }
        public string origins_old { get; set; }
        public object[] origins_tags { get; set; }
        public object[] other_nutritional_substances_tags { get; set; }
        public string packaging { get; set; }
        public string[] packaging_hierarchy { get; set; }
        public string packaging_lc { get; set; }
        public string[] packaging_materials_tags { get; set; }
        public string packaging_old { get; set; }
        public string packaging_old_before_taxonomization { get; set; }
        public string[] packaging_recycling_tags { get; set; }
        public string[] packaging_shapes_tags { get; set; }
        public string[] packaging_tags { get; set; }
        public Packaging2[] packagings { get; set; }
        public Packagings_Materials packagings_materials { get; set; }
        public int packagings_n { get; set; }
        public string[] photographers_tags { get; set; }
        public string pnns_groups_1 { get; set; }
        public string[] pnns_groups_1_tags { get; set; }
        public string pnns_groups_2 { get; set; }
        public string[] pnns_groups_2_tags { get; set; }
        public int popularity_key { get; set; }
        public string[] popularity_tags { get; set; }
        public string product_name { get; set; }
        public string product_name_en { get; set; }
        public string product_name_en_imported { get; set; }
        public string product_name_fr { get; set; }
        public object[] product_name_fr_debug_tags { get; set; }
        public string purchase_places { get; set; }
        public object[] purchase_places_debug_tags { get; set; }
        public string[] purchase_places_tags { get; set; }
        public string quantity { get; set; }
        public object[] removed_countries_tags { get; set; }
        public int rev { get; set; }
        public int scans_n { get; set; }
        public Selected_Images selected_images { get; set; }
        public string serving_quantity { get; set; }
        public string serving_size { get; set; }
        public object[] serving_size_debug_tags { get; set; }
        public string serving_size_imported { get; set; }
        public Source[] sources { get; set; }
        public Sources_Fields sources_fields { get; set; }
        public string states { get; set; }
        public string[] states_hierarchy { get; set; }
        public string[] states_tags { get; set; }
        public string stores { get; set; }
        public object[] stores_debug_tags { get; set; }
        public object[] stores_tags { get; set; }
        public string traces { get; set; }
        public object[] traces_debug_tags { get; set; }
        public string traces_from_ingredients { get; set; }
        public string traces_from_user { get; set; }
        public object[] traces_hierarchy { get; set; }
        public object[] traces_tags { get; set; }
        public int unique_scans_n { get; set; }
        public int unknown_ingredients_n { get; set; }
        public object[] unknown_nutrients_tags { get; set; }
        public string update_key { get; set; }
        public object[] vitamins_prev_tags { get; set; }
        public object[] vitamins_tags { get; set; }
    }

    public class Categories_Properties {
    }

    public class Category_Properties {
    }

    public class Ecoscore_Data {
        public Adjustments adjustments { get; set; }
        public Agribalyse agribalyse { get; set; }
        public Missing missing { get; set; }
        public int missing_agribalyse_match_warning { get; set; }
        public Scores scores { get; set; }
        public string status { get; set; }
    }

    public class Adjustments {
        public Origins_Of_Ingredients origins_of_ingredients { get; set; }
        public Packaging packaging { get; set; }
        public Production_System production_system { get; set; }
        public Threatened_Species threatened_species { get; set; }
    }

    public class Origins_Of_Ingredients {
        public Aggregated_Origins[] aggregated_origins { get; set; }
        public int epi_score { get; set; }
        public int epi_value { get; set; }
        public string[] origins_from_categories { get; set; }
        public string[] origins_from_origins_field { get; set; }
        public int transportation_score { get; set; }
        public Transportation_Scores transportation_scores { get; set; }
        public int transportation_value { get; set; }
        public Transportation_Values transportation_values { get; set; }
        public int value { get; set; }
        public Values values { get; set; }
        public string warning { get; set; }
    }

    public class Transportation_Scores {
        public int ad { get; set; }
        public int al { get; set; }
        public int at { get; set; }
        public int ax { get; set; }
        public int ba { get; set; }
        public int be { get; set; }
        public int bg { get; set; }
        public int ch { get; set; }
        public int cy { get; set; }
        public int cz { get; set; }
        public int de { get; set; }
        public int dk { get; set; }
        public int dz { get; set; }
        public int ee { get; set; }
        public int eg { get; set; }
        public int es { get; set; }
        public int fi { get; set; }
        public int fo { get; set; }
        public int fr { get; set; }
        public int gg { get; set; }
        public int gi { get; set; }
        public int gr { get; set; }
        public int hr { get; set; }
        public int hu { get; set; }
        public int ie { get; set; }
        public int il { get; set; }
        public int im { get; set; }
        public int _is { get; set; }
        public int it { get; set; }
        public int je { get; set; }
        public int lb { get; set; }
        public int li { get; set; }
        public int lt { get; set; }
        public int lu { get; set; }
        public int lv { get; set; }
        public int ly { get; set; }
        public int ma { get; set; }
        public int mc { get; set; }
        public int md { get; set; }
        public int me { get; set; }
        public int mk { get; set; }
        public int mt { get; set; }
        public int nl { get; set; }
        public int no { get; set; }
        public int pl { get; set; }
        public int ps { get; set; }
        public int pt { get; set; }
        public int ro { get; set; }
        public int rs { get; set; }
        public int se { get; set; }
        public int si { get; set; }
        public int sj { get; set; }
        public int sk { get; set; }
        public int sm { get; set; }
        public int sy { get; set; }
        public int tn { get; set; }
        public int tr { get; set; }
        public int ua { get; set; }
        public int uk { get; set; }
        public int us { get; set; }
        public int va { get; set; }
        public int world { get; set; }
        public int xk { get; set; }
    }

    public class Transportation_Values {
        public int ad { get; set; }
        public int al { get; set; }
        public int at { get; set; }
        public int ax { get; set; }
        public int ba { get; set; }
        public int be { get; set; }
        public int bg { get; set; }
        public int ch { get; set; }
        public int cy { get; set; }
        public int cz { get; set; }
        public int de { get; set; }
        public int dk { get; set; }
        public int dz { get; set; }
        public int ee { get; set; }
        public int eg { get; set; }
        public int es { get; set; }
        public int fi { get; set; }
        public int fo { get; set; }
        public int fr { get; set; }
        public int gg { get; set; }
        public int gi { get; set; }
        public int gr { get; set; }
        public int hr { get; set; }
        public int hu { get; set; }
        public int ie { get; set; }
        public int il { get; set; }
        public int im { get; set; }
        public int _is { get; set; }
        public int it { get; set; }
        public int je { get; set; }
        public int lb { get; set; }
        public int li { get; set; }
        public int lt { get; set; }
        public int lu { get; set; }
        public int lv { get; set; }
        public int ly { get; set; }
        public int ma { get; set; }
        public int mc { get; set; }
        public int md { get; set; }
        public int me { get; set; }
        public int mk { get; set; }
        public int mt { get; set; }
        public int nl { get; set; }
        public int no { get; set; }
        public int pl { get; set; }
        public int ps { get; set; }
        public int pt { get; set; }
        public int ro { get; set; }
        public int rs { get; set; }
        public int se { get; set; }
        public int si { get; set; }
        public int sj { get; set; }
        public int sk { get; set; }
        public int sm { get; set; }
        public int sy { get; set; }
        public int tn { get; set; }
        public int tr { get; set; }
        public int ua { get; set; }
        public int uk { get; set; }
        public int us { get; set; }
        public int va { get; set; }
        public int world { get; set; }
        public int xk { get; set; }
    }

    public class Values {
        public int ad { get; set; }
        public int al { get; set; }
        public int at { get; set; }
        public int ax { get; set; }
        public int ba { get; set; }
        public int be { get; set; }
        public int bg { get; set; }
        public int ch { get; set; }
        public int cy { get; set; }
        public int cz { get; set; }
        public int de { get; set; }
        public int dk { get; set; }
        public int dz { get; set; }
        public int ee { get; set; }
        public int eg { get; set; }
        public int es { get; set; }
        public int fi { get; set; }
        public int fo { get; set; }
        public int fr { get; set; }
        public int gg { get; set; }
        public int gi { get; set; }
        public int gr { get; set; }
        public int hr { get; set; }
        public int hu { get; set; }
        public int ie { get; set; }
        public int il { get; set; }
        public int im { get; set; }
        public int _is { get; set; }
        public int it { get; set; }
        public int je { get; set; }
        public int lb { get; set; }
        public int li { get; set; }
        public int lt { get; set; }
        public int lu { get; set; }
        public int lv { get; set; }
        public int ly { get; set; }
        public int ma { get; set; }
        public int mc { get; set; }
        public int md { get; set; }
        public int me { get; set; }
        public int mk { get; set; }
        public int mt { get; set; }
        public int nl { get; set; }
        public int no { get; set; }
        public int pl { get; set; }
        public int ps { get; set; }
        public int pt { get; set; }
        public int ro { get; set; }
        public int rs { get; set; }
        public int se { get; set; }
        public int si { get; set; }
        public int sj { get; set; }
        public int sk { get; set; }
        public int sm { get; set; }
        public int sy { get; set; }
        public int tn { get; set; }
        public int tr { get; set; }
        public int ua { get; set; }
        public int uk { get; set; }
        public int us { get; set; }
        public int va { get; set; }
        public int world { get; set; }
        public int xk { get; set; }
    }

    public class Aggregated_Origins {
        public string epi_score { get; set; }
        public string origin { get; set; }
        public int percent { get; set; }
        public object transportation_score { get; set; }
    }

    public class Packaging {
        public int non_recyclable_and_non_biodegradable_materials { get; set; }
        public Packaging1[] packagings { get; set; }
        public int score { get; set; }
        public int value { get; set; }
    }

    public class Packaging1 {
        public int ecoscore_material_score { get; set; }
        public int ecoscore_shape_ratio { get; set; }
        public string material { get; set; }
        public string recycling { get; set; }
        public string shape { get; set; }
    }

    public class Production_System {
        public object[] labels { get; set; }
        public int value { get; set; }
        public string warning { get; set; }
    }

    public class Threatened_Species {
    }

    public class Agribalyse {
        public string warning { get; set; }
    }

    public class Missing {
        public int agb_category { get; set; }
        public int labels { get; set; }
        public int origins { get; set; }
    }

    public class Scores {
    }

    public class Forest_Footprint_Data {
        public float footprint_per_kg { get; set; }
        public string grade { get; set; }
        public Ingredient[] ingredients { get; set; }
    }

    public class Ingredient {
        public object[] conditions_tags { get; set; }
        public float footprint_per_kg { get; set; }
        public string matching_tag_id { get; set; }
        public float percent { get; set; }
        public float percent_estimate { get; set; }
        public int processing_factor { get; set; }
        public string tag_id { get; set; }
        public string tag_type { get; set; }
        public Type type { get; set; }
    }

    public class Type {
        public float deforestation_risk { get; set; }
        public string name { get; set; }
        public float soy_feed_factor { get; set; }
        public float soy_yield { get; set; }
    }

    public class Images {
        public _1 _1 { get; set; }
        public _2 _2 { get; set; }
        public _3 _3 { get; set; }
        public _4 _4 { get; set; }
        public _5 _5 { get; set; }
        public _6 _6 { get; set; }
        public _7 _7 { get; set; }
        public _8 _8 { get; set; }
        public _9 _9 { get; set; }
        public _10 _10 { get; set; }
        public _11 _11 { get; set; }
        public _12 _12 { get; set; }
        public _13 _13 { get; set; }
        public _14 _14 { get; set; }
        public _15 _15 { get; set; }
        public Front_En front_en { get; set; }
        public Ingredients_Fr ingredients_fr { get; set; }
        public Nutrition_Fr nutrition_fr { get; set; }
    }

    public class _1 {
        public Sizes sizes { get; set; }
        public string uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes {
        public _100 _100 { get; set; }
        public _400 _400 { get; set; }
        public Full full { get; set; }
    }

    public class _100 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _400 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _2 {
        public Sizes1 sizes { get; set; }
        public string uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes1 {
        public _1001 _100 { get; set; }
        public _4001 _400 { get; set; }
        public Full1 full { get; set; }
    }

    public class _1001 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4001 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full1 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _3 {
        public Sizes2 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes2 {
        public _1002 _100 { get; set; }
        public _4002 _400 { get; set; }
        public Full2 full { get; set; }
    }

    public class _1002 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4002 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full2 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4 {
        public Sizes3 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes3 {
        public _1003 _100 { get; set; }
        public _4003 _400 { get; set; }
        public Full3 full { get; set; }
    }

    public class _1003 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4003 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full3 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _5 {
        public Sizes4 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes4 {
        public _1004 _100 { get; set; }
        public _4004 _400 { get; set; }
        public Full4 full { get; set; }
    }

    public class _1004 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4004 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full4 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _6 {
        public Sizes5 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes5 {
        public _1005 _100 { get; set; }
        public _4005 _400 { get; set; }
        public Full5 full { get; set; }
    }

    public class _1005 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4005 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full5 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _7 {
        public Sizes6 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes6 {
        public _1006 _100 { get; set; }
        public _4006 _400 { get; set; }
        public Full6 full { get; set; }
    }

    public class _1006 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4006 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full6 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _8 {
        public Sizes7 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes7 {
        public _1007 _100 { get; set; }
        public _4007 _400 { get; set; }
        public Full7 full { get; set; }
    }

    public class _1007 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4007 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full7 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _9 {
        public Sizes8 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes8 {
        public _1008 _100 { get; set; }
        public _4008 _400 { get; set; }
        public Full8 full { get; set; }
    }

    public class _1008 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4008 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full8 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _10 {
        public Sizes9 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes9 {
        public _1009 _100 { get; set; }
        public _4009 _400 { get; set; }
        public Full9 full { get; set; }
    }

    public class _1009 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _4009 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full9 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _11 {
        public Sizes10 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes10 {
        public _10010 _100 { get; set; }
        public _40010 _400 { get; set; }
        public Full10 full { get; set; }
    }

    public class _10010 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40010 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full10 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _12 {
        public Sizes11 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes11 {
        public _10011 _100 { get; set; }
        public _40011 _400 { get; set; }
        public Full11 full { get; set; }
    }

    public class _10011 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40011 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full11 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _13 {
        public Sizes12 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes12 {
        public _10012 _100 { get; set; }
        public _40012 _400 { get; set; }
        public Full12 full { get; set; }
    }

    public class _10012 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40012 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full12 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _14 {
        public Sizes13 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes13 {
        public _10013 _100 { get; set; }
        public _40013 _400 { get; set; }
        public Full13 full { get; set; }
    }

    public class _10013 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40013 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full13 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _15 {
        public Sizes14 sizes { get; set; }
        public int uploaded_t { get; set; }
        public string uploader { get; set; }
    }

    public class Sizes14 {
        public _10014 _100 { get; set; }
        public _40014 _400 { get; set; }
        public Full14 full { get; set; }
    }

    public class _10014 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40014 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full14 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Front_En {
        public int angle { get; set; }
        public string geometry { get; set; }
        public string imgid { get; set; }
        public object normalize { get; set; }
        public string rev { get; set; }
        public Sizes15 sizes { get; set; }
        public object white_magic { get; set; }
        public string x1 { get; set; }
        public string x2 { get; set; }
        public string y1 { get; set; }
        public string y2 { get; set; }
    }

    public class Sizes15 {
        public _10015 _100 { get; set; }
        public _200 _200 { get; set; }
        public _40015 _400 { get; set; }
        public Full15 full { get; set; }
    }

    public class _10015 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _200 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40015 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full15 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Ingredients_Fr {
        public object angle { get; set; }
        public string geometry { get; set; }
        public string imgid { get; set; }
        public string normalize { get; set; }
        public int ocr { get; set; }
        public string orientation { get; set; }
        public string rev { get; set; }
        public Sizes16 sizes { get; set; }
        public string white_magic { get; set; }
        public object x1 { get; set; }
        public object x2 { get; set; }
        public object y1 { get; set; }
        public object y2 { get; set; }
    }

    public class Sizes16 {
        public _10016 _100 { get; set; }
        public _2001 _200 { get; set; }
        public _40016 _400 { get; set; }
        public Full16 full { get; set; }
    }

    public class _10016 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _2001 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40016 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full16 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Nutrition_Fr {
        public object angle { get; set; }
        public string geometry { get; set; }
        public string imgid { get; set; }
        public string normalize { get; set; }
        public int ocr { get; set; }
        public string orientation { get; set; }
        public string rev { get; set; }
        public Sizes17 sizes { get; set; }
        public string white_magic { get; set; }
        public object x1 { get; set; }
        public object x2 { get; set; }
        public object y1 { get; set; }
        public object y2 { get; set; }
    }

    public class Sizes17 {
        public _10017 _100 { get; set; }
        public _2002 _200 { get; set; }
        public _40017 _400 { get; set; }
        public Full17 full { get; set; }
    }

    public class _10017 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _2002 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class _40017 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Full17 {
        public int h { get; set; }
        public int w { get; set; }
    }

    public class Ingredients_Analysis {
        public string[] ennonvegan { get; set; }
        public string[] ennonvegetarian { get; set; }
    }

    public class Languages {
        public int enenglish { get; set; }
        public int enfrench { get; set; }
    }

    public class Languages_Codes {
        public int en { get; set; }
        public int fr { get; set; }
    }

    public class Nova_Groups_Markers {
        public string[][] _3 { get; set; }
    }

    public class Nutrient_Levels {
        public string fat { get; set; }
        public string salt { get; set; }
        public string saturatedfat { get; set; }
        public string sugars { get; set; }
    }

    public class Nutriments {
        public int calcium { get; set; }
        public int calcium_100g { get; set; }
        public int calcium_serving { get; set; }
        public string calcium_unit { get; set; }
        public int calcium_value { get; set; }
        public float carbohydrates { get; set; }
        public float carbohydrates_100g { get; set; }
        public int carbohydrates_serving { get; set; }
        public string carbohydrates_unit { get; set; }
        public float carbohydrates_value { get; set; }
        public float cholesterol { get; set; }
        public float cholesterol_100g { get; set; }
        public string cholesterol_label { get; set; }
        public float cholesterol_serving { get; set; }
        public string cholesterol_unit { get; set; }
        public int cholesterol_value { get; set; }
        public int energy { get; set; }
        public int energykcal { get; set; }
        public int energykcal_100g { get; set; }
        public int energykcal_serving { get; set; }
        public string energykcal_unit { get; set; }
        public int energykcal_value { get; set; }
        public float energykcal_value_computed { get; set; }
        public int energy_100g { get; set; }
        public int energy_serving { get; set; }
        public string energy_unit { get; set; }
        public int energy_value { get; set; }
        public float fat { get; set; }
        public float fat_100g { get; set; }
        public int fat_serving { get; set; }
        public string fat_unit { get; set; }
        public float fat_value { get; set; }
        public int fiber { get; set; }
        public int fiber_100g { get; set; }
        public int fiber_serving { get; set; }
        public string fiber_unit { get; set; }
        public int fiber_value { get; set; }
        public int fruitsvegetableslegumesestimatefromingredients_100g { get; set; }
        public int fruitsvegetableslegumesestimatefromingredients_serving { get; set; }
        public int fruitsvegetablesnutsestimatefromingredients_100g { get; set; }
        public int fruitsvegetablesnutsestimatefromingredients_serving { get; set; }
        public float iron { get; set; }
        public float iron_100g { get; set; }
        public float iron_serving { get; set; }
        public string iron_unit { get; set; }
        public float iron_value { get; set; }
        public int novagroup { get; set; }
        public int novagroup_100g { get; set; }
        public int novagroup_serving { get; set; }
        public int nutritionscorefr { get; set; }
        public int nutritionscorefr_100g { get; set; }
        public float proteins { get; set; }
        public float proteins_100g { get; set; }
        public int proteins_serving { get; set; }
        public string proteins_unit { get; set; }
        public float proteins_value { get; set; }
        public float salt { get; set; }
        public float salt_100g { get; set; }
        public float salt_serving { get; set; }
        public string salt_unit { get; set; }
        public float salt_value { get; set; }
        public float saturatedfat { get; set; }
        public float saturatedfat_100g { get; set; }
        public int saturatedfat_serving { get; set; }
        public string saturatedfat_unit { get; set; }
        public float saturatedfat_value { get; set; }
        public float sodium { get; set; }
        public float sodium_100g { get; set; }
        public float sodium_serving { get; set; }
        public string sodium_unit { get; set; }
        public float sodium_value { get; set; }
        public int sugars { get; set; }
        public int sugars_100g { get; set; }
        public int sugars_serving { get; set; }
        public string sugars_unit { get; set; }
        public int sugars_value { get; set; }
        public int transfat { get; set; }
        public int transfat_100g { get; set; }
        public int transfat_serving { get; set; }
        public string transfat_unit { get; set; }
        public int transfat_value { get; set; }
        public int vitamina { get; set; }
        public int vitamina_100g { get; set; }
        public int vitamina_serving { get; set; }
        public string vitamina_unit { get; set; }
        public int vitamina_value { get; set; }
        public float vitaminc { get; set; }
        public float vitaminc_100g { get; set; }
        public float vitaminc_serving { get; set; }
        public string vitaminc_unit { get; set; }
        public float vitaminc_value { get; set; }
    }

    public class Nutriscore {
        public _2021 _2021 { get; set; }
        public _2023 _2023 { get; set; }
    }

    public class _2021 {
        public int category_available { get; set; }
        public Data data { get; set; }
        public string grade { get; set; }
        public int nutrients_available { get; set; }
        public int nutriscore_applicable { get; set; }
        public int nutriscore_computed { get; set; }
        public int score { get; set; }
    }

    public class Data {
        public int energy { get; set; }
        public int energy_points { get; set; }
        public int energy_value { get; set; }
        public int fiber { get; set; }
        public int fiber_points { get; set; }
        public int fiber_value { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils_points { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils_value { get; set; }
        public int is_beverage { get; set; }
        public int is_cheese { get; set; }
        public int is_fat { get; set; }
        public int is_water { get; set; }
        public int negative_points { get; set; }
        public int positive_points { get; set; }
        public float proteins { get; set; }
        public int proteins_points { get; set; }
        public float proteins_value { get; set; }
        public float saturated_fat { get; set; }
        public int saturated_fat_points { get; set; }
        public float saturated_fat_value { get; set; }
        public int sodium { get; set; }
        public int sodium_points { get; set; }
        public int sodium_value { get; set; }
        public int sugars { get; set; }
        public int sugars_points { get; set; }
        public int sugars_value { get; set; }
    }

    public class _2023 {
        public int category_available { get; set; }
        public Data1 data { get; set; }
        public string grade { get; set; }
        public int nutrients_available { get; set; }
        public int nutriscore_applicable { get; set; }
        public int nutriscore_computed { get; set; }
        public int score { get; set; }
    }

    public class Data1 {
        public Components components { get; set; }
        public int count_proteins { get; set; }
        public string count_proteins_reason { get; set; }
        public int is_beverage { get; set; }
        public int is_cheese { get; set; }
        public int is_fat_oil_nuts_seeds { get; set; }
        public int is_red_meat_product { get; set; }
        public int is_water { get; set; }
        public int negative_points { get; set; }
        public int negative_points_max { get; set; }
        public string[] positive_nutrients { get; set; }
        public int positive_points { get; set; }
        public int positive_points_max { get; set; }
        public string proteins_points_limited_reason { get; set; }
    }

    public class Components {
        public Negative[] negative { get; set; }
        public Positive[] positive { get; set; }
    }

    public class Negative {
        public string id { get; set; }
        public int points { get; set; }
        public int points_max { get; set; }
        public string unit { get; set; }
        public float value { get; set; }
    }

    public class Positive {
        public string id { get; set; }
        public int points { get; set; }
        public int points_max { get; set; }
        public string unit { get; set; }
        public int value { get; set; }
    }

    public class Nutriscore_Data {
        public int energy { get; set; }
        public int energy_points { get; set; }
        public int energy_value { get; set; }
        public int fiber { get; set; }
        public int fiber_points { get; set; }
        public int fiber_value { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils_points { get; set; }
        public int fruits_vegetables_nuts_colza_walnut_olive_oils_value { get; set; }
        public string grade { get; set; }
        public int is_beverage { get; set; }
        public int is_cheese { get; set; }
        public int is_fat { get; set; }
        public int is_water { get; set; }
        public int negative_points { get; set; }
        public int positive_points { get; set; }
        public float proteins { get; set; }
        public int proteins_points { get; set; }
        public float proteins_value { get; set; }
        public float saturated_fat { get; set; }
        public int saturated_fat_points { get; set; }
        public float saturated_fat_value { get; set; }
        public int score { get; set; }
        public int sodium { get; set; }
        public int sodium_points { get; set; }
        public int sodium_value { get; set; }
        public int sugars { get; set; }
        public int sugars_points { get; set; }
        public int sugars_value { get; set; }
    }

    public class Packagings_Materials {
        public All all { get; set; }
        public EnMetal enmetal { get; set; }
    }

    public class All {
    }

    public class EnMetal {
    }

    public class Selected_Images {
        public Front front { get; set; }
        public Ingredients ingredients { get; set; }
        public Nutrition nutrition { get; set; }
    }

    public class Front {
        public Display display { get; set; }
        public Small small { get; set; }
        public Thumb thumb { get; set; }
    }

    public class Display {
        public string en { get; set; }
    }

    public class Small {
        public string en { get; set; }
    }

    public class Thumb {
        public string en { get; set; }
    }

    public class Ingredients {
        public Display1 display { get; set; }
        public Small1 small { get; set; }
        public Thumb1 thumb { get; set; }
    }

    public class Display1 {
        public string fr { get; set; }
    }

    public class Small1 {
        public string fr { get; set; }
    }

    public class Thumb1 {
        public string fr { get; set; }
    }

    public class Nutrition {
        public Display2 display { get; set; }
        public Small2 small { get; set; }
        public Thumb2 thumb { get; set; }
    }

    public class Display2 {
        public string fr { get; set; }
    }

    public class Small2 {
        public string fr { get; set; }
    }

    public class Thumb2 {
        public string fr { get; set; }
    }

    public class Sources_Fields {
        public OrgDatabaseUsda orgdatabaseusda { get; set; }
    }

    public class OrgDatabaseUsda {
        public DateTime available_date { get; set; }
        public string fdc_category { get; set; }
        public string fdc_data_source { get; set; }
        public string fdc_id { get; set; }
        public DateTime modified_date { get; set; }
        public DateTime publication_date { get; set; }
    }

    public class Ingredient1 {
        public string ciqual_proxy_food_code { get; set; }
        public string id { get; set; }
        public float percent_estimate { get; set; }
        public float percent_max { get; set; }
        public float percent_min { get; set; }
        public int rank { get; set; }
        public string text { get; set; }
        public string vegan { get; set; }
        public string vegetarian { get; set; }
        public string processing { get; set; }
        public string ciqual_food_code { get; set; }
    }

    public class Packaging2 {
        public string material { get; set; }
        public string recycling { get; set; }
        public string shape { get; set; }
    }

    public class Source {
        public string[] fields { get; set; }
        public string id { get; set; }
        public object[] images { get; set; }
        public int import_t { get; set; }
        public object manufacturer { get; set; }
        public string name { get; set; }
        public object url { get; set; }
    }

}
