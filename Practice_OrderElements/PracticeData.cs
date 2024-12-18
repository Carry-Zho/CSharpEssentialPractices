namespace Practice_OrderElements
{
    internal static class PracticeData
    {
        public static (string Module, int CaseID, string Case, string Case_Description, string Result)[] DataPkg { get; }
        = new[]
        {
            ("PO",16,"Have attachments","Success","NG"),
            ("PO",12,"No Fapiao","OCR not verified","Ok"),            
            ("PO",14,"No Fapiao","Status Reviewed - Success - Update old row(Success)","Ok"),
            ("PO",15,"Have attachments","Success","Ok"),            
            ("PO",17,"No Fapiao","Failed","NG"),
            ("PO",13,"No Fapiao","Status Success - Add new row(Duplicated)","Ok"),
            
            ("Non-PO",22,"No attachments","More than G/L Account Success","NG"),
            ("Non-PO",20,"No attachments","One G/L Account Success","Ok"),
            ("Non-PO",21,"No attachments","One G/L Account Failed","Ok"),
            ("Non-PO",23,"Have attachments","One G/L Account Success","NG"),

            ("Check History",1,"No Fapiao","PO/No-Po Success","Ok"),
            ("Check History",15,"Have attachments","Status Reviewed - Failed - Update old row(Failed)","NG"),
            ("Check History",16,"Have attachments","Status Others(Not Success/Reviewed) - Do nothing","NG"),
            ("Check History",9,"No Fapiao","PO/No-Po Failed","Ok"),
            ("Check History",10,"No Fapiao","Verified; PO/No-Po Success","Ok"),
            ("Check History",11,"No Fapiao","Verified; PO/No-Po Failed","NG"),
            ("Check History",24,"No Fapiao","PO/No-Po Failed","Ok"),
            ("Check History",24,"No Fapiao","PO/No-Po Failed","Ok"),
            ("Check History",24,"No Fapiao","PO/No-Po Failed","Ok"),
            ("Check History",24,"Fapiao","Success","Ok"),
            ("Check History",24,"Fapiao","Success","Ok"),
            ("Check History",24,"Fapiao","Success","NG"),
            ("Check History",24,"Fapiao","Success","NG"),
            ("Check History",24,"No Fapiao","PO/No-Po Failed","NG"),
            ("Check History",24,"No Fapiao","PO/No-Po Failed","NG"),

            ("Move SharePint",7,"Folder","Rename","NG"),
            ("Move SharePint",4,"File","Same name","Ok"),
            ("Move SharePint",6,"Folder","Same name","NG"),
            ("Move SharePint",5,"File","Rename","Ok"),            

            ("Download from SharePoint",1,"File","","Ok"),
            ("Download from SharePoint",2,"Folder","","NG")
        };
    }
}
