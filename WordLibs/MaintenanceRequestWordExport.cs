using DocumentFormat.OpenXml.Packaging;
using SACOMaintenance.Common.ModelDB;
using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace WordLibs
{
    public class MaintenanceRequestWordExport
    {
        
        public void CreateMaintenanceRequestReport(MaintRequestInitiation maintReqSingle)
        {         
            using (WordprocessingDocument doc = WordprocessingDocument.Open(@"C:\Users\cabuk\Desktop\maintreqdetails.docx", true))
            {
                var document = doc.MainDocumentPart.Document;

                //loop through the preoprties of the maintenance request initation object
                foreach(PropertyInfo prop in maintReqSingle.GetType().GetProperties())
                {
                    //loop through the text in the word document
                    foreach (var text in document.Descendants<Text>())
                    {
                        //if the text found is equal to the proeprtyname then put text there
                        //the placeholder in the word document is {propertyname}
                        if (text.Text == "{" + prop.Name + "}")
                        {
                            var type = prop.Name;
                             
                            if(prop.Name == "Factory")
                            {
                                text.Text = text.Text.Replace("{Factory}", maintReqSingle.Factory.FactoryName);
                            }
                            else
                            {
                                text.Text = text.Text.Replace(prop.Name, prop.GetValue(maintReqSingle, null).ToString());
                            }                                
                        }
                    }
                }
                             
                doc.Save();
            }
        }
    }
}
