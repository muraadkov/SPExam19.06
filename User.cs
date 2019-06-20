using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPExam19._06
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Login { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string DoublePassword { get; set; }
        public string MobileNumber { get; set; }
    }
}
