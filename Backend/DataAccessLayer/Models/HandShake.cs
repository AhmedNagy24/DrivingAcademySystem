using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models
{
    public class HandShake
    {
        public int Id { get; set; }
        public string Code { get; set; } = string.Empty;
        public int RequestId { get; set; }
        public string FromUserId { get; set; }
        public string ToUserId { get; set; }
        public HandShakeStatus Status { get; set; } = HandShakeStatus.PendingCraftsmanConfirmation;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ConfirmedAt { get; set; }

    }
}
