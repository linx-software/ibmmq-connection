using IBM.WMQ;
using System.Collections;
using System.Diagnostics;

namespace IBMMQ_Connection
{
    internal class Settings
    {
        public Dictionary<string, string> ConnectionProperties { get; set; }
        public string QueueManagerName { get; set; }    
        public string QueueName { get; set; }
        public int QueueOpenOptions { get; set; }  
        
        public Hashtable GetMQConnectionProperties()
        {
            var result = new Hashtable();
            var MQCType = typeof(MQC);
            foreach (var item in ConnectionProperties)
            {
                var keyField = MQCType.GetField(item.Key, System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public);
                string? keyValue = keyField?.GetValue(null)?.ToString();
                Trace.Assert(keyValue != null, $"Connection property name {item.Key} not found in MQC.");
                result.Add(keyValue!, item.Value);
            }
            return result;
        }
    }
}
