﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic.Moves
{
    public enum MoveType
    {
        Normal,
        CastleKS,
        CastleQS,
        DoublePawn,
        Enpassant,
        PawnPromtion
    }
}
