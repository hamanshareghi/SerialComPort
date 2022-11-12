

using System.ComponentModel.DataAnnotations;

namespace SerialComPort.Model
{
    public class ConnectionLog
    {
        [Key]
        public Guid Id { get; set; }
        public string DeviceName { get; set; }
        public DateTime CreateDate { get; set; }= DateTime.Now;
        public string PortNumber { get; set; }
        public bool IsValid { get; set; } = true;
        public ConnectionLog() { }
    }
}
