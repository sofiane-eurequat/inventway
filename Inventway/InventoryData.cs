using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Inventway
{
    public class InventoryData
    {
        private String m_barcode="";
        private String m_analytique="";
        private String m_agent = "";
        private String m_structure = "";
        private String m_state = "";
        private String m_location = "";
        private String m_type_read = "";
        private DateTime m_date = new DateTime();


       /* public String analytique
        {
            get { return m_analytique; }
            set { m_analytique = value; }
        }*/

        public String structure
        {
            get { return m_structure; }
            set { m_structure = value; }
        }

        public String location
        {
            get { return m_location; }
            set { m_location = value; }
        }

        public String barcode
        {
            get { return m_barcode; }
            set { m_barcode = value; }
        }

        public String state
        {
            get { return m_state; }
            set { m_state = value; }
        }

        public String agent
        {
            get { return m_agent; }
            set { m_agent = value; }
        }
       /* public String type_read
        {
            get { return m_type_read; }
            set { m_type_read = value; }
        }
        public DateTime date
        {
            get { return m_date; }
            set { m_date = value; }
        }*/
        public InventoryData() { }

        public String toString(){
            string format ="dd/MM/yyyy,HH:mm:ss";
            StringBuilder builder = new StringBuilder();
            builder.Append(m_structure).Append(";")
                .Append(m_location).Append(";").Append(m_barcode).Append(";").Append(m_state).Append(";").Append(m_agent).Append("\n");
            return builder.ToString();
        }
        

        public InventoryData( String m_structure,   String m_location,  String m_barcode,  String m_state, 
            //String m_analytique, 
            String m_agent     
         
         //String m_type_read
         //DateTime m_date
            )
        {
             
             //m_analytique = analytique;
            
             m_structure = structure;
             m_location = location;
             m_barcode = barcode;
             m_state = barcode;
             m_agent = agent;
             //m_type_read = type_read;
             //m_date= date;
        }

    }
}
