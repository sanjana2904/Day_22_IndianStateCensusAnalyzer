using Day_22_IndianStateCensusAnalyzer.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22_IndianStateCensusAnalyzer
{
  public  class CensusAnalyser
    {
        public enum Country
        {
            INDIA, US, BRAZIL
        }

        Dictionary<string, CensusDTO> dataMap;
        public Dictionary<string, CensusDTO> LoadCensusData(string csvFilePath, Country country, string dataHeaders)
        {
            dataMap = new CSVAdapterFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }


    }
}
