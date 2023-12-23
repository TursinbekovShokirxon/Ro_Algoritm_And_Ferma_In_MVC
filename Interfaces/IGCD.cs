using Crypt.Controllers;
using Crypt.Models;

namespace Crypt.Interfaces
{
    public interface IGCD
    {
        public Pollard PollardAlgoritm(int N);
    }
}
