﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inventory.Core.Entities
{
    public class Material : EntityBase
    {
        public virtual string PartName { get; set; }
        public virtual string Description { get; set; }
        public virtual MaterialType Type { get; set; }
        public virtual decimal PiecesPerCase { get; set; }
        public virtual decimal EachesPerPiece { get; set; }
    }
}
