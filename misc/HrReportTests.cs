using NUnit.Framework;
using System.Collections.Generic;

namespace HrReportLibrary
{
    public class HrReportTests
    {
        Dictionary<string, string> translations;
        List<string> collector;
        LineConsumer lineConsumer;
        HrReport hrReport = new HrReport();

        [SetUp]
        public void SetUp() {
            translations = new Dictionary<string, string>();
            translations.Add("myMappedPosition", "myMappedPositionValue");

            collector = new List<string>();
            lineConsumer = new LineConsumer(line => collector.Add(line));

            Assert.That(collector, Has.Count.EqualTo(0));

            hrReport = new HrReport();
        }

        [Test]
        public void PrintEmployee_mapped()
        {
            hrReport.PrintEmployee("myName", "myMappedPosition", translations, lineConsumer);
            Assert.That(collector, Has.Count.EqualTo(1));
            Assert.That(collector.ToArray()[0], Is.EqualTo("myName - myMappedPositionValue"));
        }

        [Test]
        public void PrintEmployee_unmapped()
        {
            hrReport.PrintEmployee("myName", "myUnmappedPosition", translations, lineConsumer);
            Assert.That(collector, Has.Count.EqualTo(1));
            Assert.That(collector.ToArray()[0], Is.EqualTo("myName"));
        }
    }
}
