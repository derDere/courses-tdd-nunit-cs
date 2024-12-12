using System;

namespace HrReportLibrary
{
    public class HrReport
    {
        public void PrintEmployee(
            string name, 
            string position, 
            Dictionary<string, string> translations, 
            LineConsumer lineConsumer
        ) {
            string localizedPosition = "";
            if (translations.TryGetValue(position, out localizedPosition)) {
                localizedPosition = " - " + localizedPosition;
            }
            lineConsumer(name + localizedPosition);
        }

    }
    public delegate void LineConsumer(string line);

}
