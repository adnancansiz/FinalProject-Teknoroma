﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace BLL.ApiData
{
    public class EuroDolarXml
    {

        public EuroDolarXml()
        {
            string today = "http://www.tcmb.gov.tr/kurlar/today.xml";

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(today);

            Euro = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='EUR']/BanknoteSelling").InnerXml;

            Dolar = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod='USD']/BanknoteSelling").InnerXml;
        }

        public string Euro { get; set; }
        public string Dolar { get; set; }

    }
}
