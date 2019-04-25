﻿namespace TrueSync
{
    using System;

    public class SubSimplexClosestResult
    {
        private FP[] _barycentricCoords = new FP[4];
        private TSVector _closestPointOnSimplex;
        private bool _degenerate;
        private UsageBitfield _usedVertices = new UsageBitfield();

        public void Reset()
        {
            this._degenerate = false;
            this.SetBarycentricCoordinates();
            this._usedVertices.Reset();
        }

        public void SetBarycentricCoordinates()
        {
            this.SetBarycentricCoordinates(FP.Zero, FP.Zero, FP.Zero, FP.Zero);
        }

        public void SetBarycentricCoordinates(FP a, FP b, FP c, FP d)
        {
            this._barycentricCoords[0] = a;
            this._barycentricCoords[1] = b;
            this._barycentricCoords[2] = c;
            this._barycentricCoords[3] = d;
        }

        public FP[] BarycentricCoords
        {
            get
            {
                return this._barycentricCoords;
            }
            set
            {
                this._barycentricCoords = value;
            }
        }

        public TSVector ClosestPointOnSimplex
        {
            get
            {
                return this._closestPointOnSimplex;
            }
            set
            {
                this._closestPointOnSimplex = value;
            }
        }

        public bool Degenerate
        {
            get
            {
                return this._degenerate;
            }
            set
            {
                this._degenerate = value;
            }
        }

        public bool IsValid
        {
            get
            {
                return ((((this._barycentricCoords[0] >= FP.Zero) && (this._barycentricCoords[1] >= FP.Zero)) && (this._barycentricCoords[2] >= FP.Zero)) && (this._barycentricCoords[3] >= FP.Zero));
            }
        }

        public UsageBitfield UsedVertices
        {
            get
            {
                return this._usedVertices;
            }
            set
            {
                this._usedVertices = value;
            }
        }
    }
}

