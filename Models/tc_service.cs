//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tc_service
    {
        public decimal service_id { get; set; }
        public Nullable<decimal> obj_type { get; set; }
        public Nullable<decimal> service_type { get; set; }
        public string account_id { get; set; }
        public string contact_id { get; set; }
        public string service_phone { get; set; }
        public string service_addr { get; set; }
        public Nullable<decimal> service_priority { get; set; }
        public string service_subject { get; set; }
        public string service_details { get; set; }
        public Nullable<decimal> queue_id { get; set; }
        public Nullable<short> service_status { get; set; }
        public string dept_id { get; set; }
        public string owner_user_id { get; set; }
        public Nullable<decimal> asset_id { get; set; }
        public string prod_id { get; set; }
        public Nullable<decimal> plan_hour { get; set; }
        public Nullable<decimal> actual_hour { get; set; }
        public Nullable<System.DateTime> request_time { get; set; }
        public Nullable<System.DateTime> limited_time { get; set; }
        public Nullable<System.DateTime> come_into_queue_time { get; set; }
        public Nullable<System.DateTime> plan_deal_start_time { get; set; }
        public Nullable<System.DateTime> plan_deal_end_time { get; set; }
        public Nullable<System.DateTime> actual_deal_start_time { get; set; }
        public Nullable<System.DateTime> actual_deal_end_time { get; set; }
        public string service_result { get; set; }
        public Nullable<decimal> expense { get; set; }
        public Nullable<decimal> approved_expense { get; set; }
        public Nullable<System.DateTime> touch_time { get; set; }
        public string identify_code { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
        public string create_user_id { get; set; }
        public Nullable<System.DateTime> modify_time { get; set; }
        public string modify_user_id { get; set; }
        public Nullable<short> is_close { get; set; }
        public Nullable<System.DateTime> close_time { get; set; }
        public string close_user_id { get; set; }
        public Nullable<short> is_deleted { get; set; }
        public string deleted_user_id { get; set; }
        public Nullable<System.DateTime> deleted_time { get; set; }
        public Nullable<decimal> deleted_id { get; set; }
        public Nullable<short> server_flag { get; set; }
        public byte[] crm_timestamp { get; set; }
        public Nullable<short> svr_int01 { get; set; }
        public Nullable<short> svr_int02 { get; set; }
        public Nullable<short> svr_int03 { get; set; }
        public Nullable<short> svr_int04 { get; set; }
        public Nullable<short> svr_int05 { get; set; }
        public Nullable<short> svr_int06 { get; set; }
        public Nullable<short> svr_int07 { get; set; }
        public Nullable<short> svr_int08 { get; set; }
        public Nullable<short> svr_int09 { get; set; }
        public Nullable<short> svr_int10 { get; set; }
        public Nullable<short> svr_int11 { get; set; }
        public Nullable<short> svr_int12 { get; set; }
        public Nullable<short> svr_int13 { get; set; }
        public Nullable<short> svr_int14 { get; set; }
        public Nullable<short> svr_int15 { get; set; }
        public Nullable<short> svr_int16 { get; set; }
        public Nullable<short> svr_int17 { get; set; }
        public Nullable<short> svr_int18 { get; set; }
        public Nullable<short> svr_int19 { get; set; }
        public Nullable<short> svr_int20 { get; set; }
        public Nullable<short> svr_int21 { get; set; }
        public Nullable<short> svr_int22 { get; set; }
        public Nullable<short> svr_int23 { get; set; }
        public Nullable<short> svr_int24 { get; set; }
        public string svr_multi01 { get; set; }
        public string svr_multi02 { get; set; }
        public string svr_multi03 { get; set; }
        public string svr_multi04 { get; set; }
        public string svr_multi05 { get; set; }
        public string svr_multi06 { get; set; }
        public string svr_char01 { get; set; }
        public string svr_char02 { get; set; }
        public string svr_char03 { get; set; }
        public string svr_char04 { get; set; }
        public string svr_char05 { get; set; }
        public string svr_char06 { get; set; }
        public string svr_char07 { get; set; }
        public string svr_char08 { get; set; }
        public string svr_char09 { get; set; }
        public string svr_char10 { get; set; }
        public string svr_char11 { get; set; }
        public string svr_char12 { get; set; }
        public Nullable<decimal> svr_dec01 { get; set; }
        public Nullable<decimal> svr_dec02 { get; set; }
        public Nullable<decimal> svr_dec03 { get; set; }
        public Nullable<decimal> svr_dec04 { get; set; }
        public Nullable<decimal> svr_dec05 { get; set; }
        public Nullable<decimal> svr_dec06 { get; set; }
        public Nullable<decimal> svr_dec07 { get; set; }
        public Nullable<decimal> svr_dec08 { get; set; }
        public Nullable<decimal> svr_dec09 { get; set; }
        public Nullable<decimal> svr_dec10 { get; set; }
        public Nullable<decimal> svr_dec11 { get; set; }
        public Nullable<decimal> svr_dec12 { get; set; }
        public Nullable<decimal> svr_dec13 { get; set; }
        public Nullable<decimal> svr_dec14 { get; set; }
        public Nullable<decimal> svr_dec15 { get; set; }
        public Nullable<decimal> svr_dec16 { get; set; }
        public Nullable<System.DateTime> svr_date01 { get; set; }
        public Nullable<System.DateTime> svr_date02 { get; set; }
        public Nullable<System.DateTime> svr_date03 { get; set; }
        public Nullable<System.DateTime> svr_date04 { get; set; }
        public Nullable<System.DateTime> svr_date05 { get; set; }
        public Nullable<System.DateTime> svr_date06 { get; set; }
        public Nullable<System.DateTime> svr_date07 { get; set; }
        public Nullable<System.DateTime> svr_date08 { get; set; }
        public string svr_refid01 { get; set; }
        public string svr_refid02 { get; set; }
        public Nullable<decimal> audit_stage_id { get; set; }
        public Nullable<decimal> audit_flow_id { get; set; }
        public Nullable<short> audit_flag { get; set; }
        public string submit_user_id { get; set; }
        public Nullable<System.DateTime> submit_time { get; set; }
        public string privilege_01 { get; set; }
        public string privilege_02 { get; set; }
        public string privilege_03 { get; set; }
        public string privilege_04 { get; set; }
        public string audit_user_id { get; set; }
        public Nullable<System.DateTime> audit_time { get; set; }
        public string ufcode { get; set; }
        public Nullable<short> iswfcontrolled { get; set; }
        public string iverifystate { get; set; }
        public string cVerifier { get; set; }
        public Nullable<System.DateTime> dverifydate { get; set; }
        public string CCurrentAuditor { get; set; }
        public string finaluser_id { get; set; }
        public string mobile { get; set; }
        public string new_contract_id { get; set; }
        public string finaluser_contract_id { get; set; }
        public Nullable<short> workcondition { get; set; }
        public Nullable<short> executestate { get; set; }
        public string noprocessreason { get; set; }
        public Nullable<short> returnvisit { get; set; }
        public string ivouchstate { get; set; }
        public string failure_id { get; set; }
        public string production_intruduction { get; set; }
        public Nullable<short> service_source { get; set; }
    }
}
