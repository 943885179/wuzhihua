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
    
    public partial class EB_Trade
    {
        public long autoID { get; set; }
        public string tid { get; set; }
        public string title { get; set; }
        public string num_iid { get; set; }
        public Nullable<decimal> num { get; set; }
        public Nullable<decimal> total_fee { get; set; }
        public Nullable<decimal> discount_fee { get; set; }
        public Nullable<decimal> adjust_fee { get; set; }
        public Nullable<decimal> post_fee { get; set; }
        public Nullable<decimal> payment { get; set; }
        public string promotion { get; set; }
        public string buyer_nick { get; set; }
        public string buyer_message { get; set; }
        public string receiver_name { get; set; }
        public string receiver_state { get; set; }
        public string receiver_city { get; set; }
        public string receiver_district { get; set; }
        public string receiver_address { get; set; }
        public string receiver_zip { get; set; }
        public string receiver_mobile { get; set; }
        public string receiver_phone { get; set; }
        public string buyer_email { get; set; }
        public string seller_memo { get; set; }
        public Nullable<System.DateTime> created { get; set; }
        public Nullable<System.DateTime> pay_time { get; set; }
        public Nullable<System.DateTime> modified { get; set; }
        public Nullable<System.DateTime> end_time { get; set; }
        public string invoice_name { get; set; }
        public string shipping_type { get; set; }
        public string alipay_id { get; set; }
        public string buyer_alipay_no { get; set; }
        public string alipay_no { get; set; }
        public Nullable<decimal> seller_cod_fee { get; set; }
        public Nullable<decimal> buyer_cod_fee { get; set; }
        public Nullable<decimal> cod_fee { get; set; }
        public Nullable<decimal> express_agency_fee { get; set; }
        public Nullable<bool> has_post_fee { get; set; }
        public string trade_memo { get; set; }
        public string seller_flag { get; set; }
        public Nullable<bool> has_yfx { get; set; }
        public Nullable<decimal> yfx_fee { get; set; }
        public string yfx_id { get; set; }
        public Nullable<int> point_fee { get; set; }
        public Nullable<int> real_point_fee { get; set; }
        public string status { get; set; }
        public string type { get; set; }
        public Nullable<bool> is_lgtype { get; set; }
        public Nullable<bool> is_brand_sale { get; set; }
        public Nullable<bool> is_force_wlb { get; set; }
        public string buyer_area { get; set; }
        public Nullable<int> buyer_obtain_point_fee { get; set; }
        public string trade_from { get; set; }
        public string alipay_warn_msg { get; set; }
        public string cod_status { get; set; }
        public Nullable<bool> can_rate { get; set; }
        public string service_orders { get; set; }
        public Nullable<decimal> commission_fee { get; set; }
        public string snapshot { get; set; }
        public Nullable<bool> seller_rate { get; set; }
        public Nullable<bool> buyer_rate { get; set; }
        public Nullable<System.DateTime> consign_time { get; set; }
        public Nullable<decimal> available_confirm_fee { get; set; }
        public Nullable<decimal> received_payment { get; set; }
        public Nullable<System.DateTime> timeout_action_time { get; set; }
        public Nullable<bool> is_3D { get; set; }
        public byte[] utfs { get; set; }
        public Nullable<long> cShopID { get; set; }
        public string cTradeCode { get; set; }
        public string sysStatus { get; set; }
        public Nullable<bool> isHold { get; set; }
        public Nullable<bool> isUpload { get; set; }
        public Nullable<bool> isCollection { get; set; }
        public Nullable<bool> isClosed { get; set; }
        public Nullable<bool> isBlend { get; set; }
        public Nullable<long> cExpressCoID { get; set; }
        public string cExpressCode { get; set; }
        public string cSOCode { get; set; }
        public string cShipCode { get; set; }
        public string cAPBillCode { get; set; }
        public string cApproveLog { get; set; }
        public Nullable<bool> isInvoice { get; set; }
        public string cInvoiceCode { get; set; }
        public string cCusCode { get; set; }
        public string cDepCode { get; set; }
        public string cPersonCode { get; set; }
        public string cSTCode { get; set; }
        public string cShipMode { get; set; }
        public string cSSCode { get; set; }
        public string cConfirmer { get; set; }
        public Nullable<System.DateTime> dConfirmTime { get; set; }
        public string cBizAuditer { get; set; }
        public Nullable<System.DateTime> dBizAuditTime { get; set; }
        public string cFinAuditer { get; set; }
        public Nullable<System.DateTime> dFinAuditTime { get; set; }
        public string cCloser { get; set; }
        public Nullable<System.DateTime> dCloseTime { get; set; }
        public Nullable<System.DateTime> dEffectiveTime { get; set; }
        public Nullable<System.DateTime> dShipTime { get; set; }
        public Nullable<System.DateTime> dUploadTime { get; set; }
        public Nullable<System.DateTime> dCollectionTime { get; set; }
        public string cBlender { get; set; }
        public Nullable<System.DateTime> dBlendTime { get; set; }
        public Nullable<decimal> fRefundMny { get; set; }
        public string cDefine1 { get; set; }
        public string cDefine2 { get; set; }
        public string cDefine3 { get; set; }
        public Nullable<System.DateTime> cDefine4 { get; set; }
        public Nullable<int> cDefine5 { get; set; }
        public Nullable<System.DateTime> cDefine6 { get; set; }
        public Nullable<double> cDefine7 { get; set; }
        public string cDefine8 { get; set; }
        public string cDefine9 { get; set; }
        public string cDefine10 { get; set; }
        public string cDefine11 { get; set; }
        public string cDefine12 { get; set; }
        public string cDefine13 { get; set; }
        public string cDefine14 { get; set; }
        public Nullable<int> cDefine15 { get; set; }
        public Nullable<double> cDefine16 { get; set; }
        public string cModifier { get; set; }
        public Nullable<System.DateTime> dModifyTime { get; set; }
        public Nullable<int> cSOID { get; set; }
        public Nullable<int> cShipID { get; set; }
        public Nullable<int> cAPBillID { get; set; }
        public string cBlendGUID { get; set; }
        public string cShipPrintStatus { get; set; }
        public string cExcoPrintStatus { get; set; }
        public string cApproveFlag { get; set; }
        public string cSemaphore { get; set; }
        public Nullable<bool> bCreateMember { get; set; }
        public Nullable<bool> bUpdateMember { get; set; }
        public Nullable<bool> bCreatePost { get; set; }
        public Nullable<decimal> iEBPlatDiscount { get; set; }
        public string cHoldReason { get; set; }
        public Nullable<System.DateTime> dwechatdate { get; set; }
        public string cmembercode { get; set; }
        public Nullable<long> imemberid { get; set; }
        public string cProvinceID { get; set; }
        public string cCityID { get; set; }
        public string cContyID { get; set; }
        public Nullable<byte> isPickSelf { get; set; }
        public string cFenxiaoType { get; set; }
        public string applier_nick { get; set; }
        public string receiver_card_id { get; set; }
        public string cTradeID { get; set; }
        public string tc_order_id { get; set; }
        public Nullable<decimal> buyer_payment { get; set; }
        public Nullable<decimal> jd_coupon_jingdou { get; set; }
        public Nullable<decimal> jd_coupon_ticket { get; set; }
        public Nullable<decimal> jd_coupon_card { get; set; }
        public Nullable<decimal> jd_coupon_mobile { get; set; }
    }
}
