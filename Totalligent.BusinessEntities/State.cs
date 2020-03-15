using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Totalligent.BusinessEntities
{
    public class State
    {

        private int stateId = 0;
        private string name = string.Empty;

        public int StateId { get => stateId; set => stateId = value; }
        public string Name { get => name; set => name = value; }
    }
}