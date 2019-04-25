﻿namespace TrueSync
{
    using System;
    using TrueSync.Physics2D;

    internal class ContactClone2D
    {
        public ContactEdgeClone2D _nodeA = new ContactEdgeClone2D();
        public ContactEdgeClone2D _nodeB = new ContactEdgeClone2D();
        public FP _toi;
        public int _toiCount;
        public TrueSync.Physics2D.Contact.ContactType _type;
        public int ChildIndexA;
        public int ChildIndexB;
        public bool Enabled;
        public bool FilterFlag;
        public Fixture FixtureA;
        public Fixture FixtureB;
        public FP Friction;
        public bool IslandFlag;
        public bool IsTouching;
        public TrueSync.Physics2D.Manifold Manifold = new TrueSync.Physics2D.Manifold();
        public FP Restitution;
        public FP TangentSpeed;
        public bool TOIFlag;

        public void Clone(TrueSync.Physics2D.Contact contact)
        {
            this._type = contact._type;
            this._toiCount = contact._toiCount;
            this._toi = contact._toi;
            this.Friction = contact.Friction;
            this.Restitution = contact.Restitution;
            this.TangentSpeed = contact.TangentSpeed;
            this.Enabled = contact.Enabled;
            this.ChildIndexA = contact.ChildIndexA;
            this.ChildIndexB = contact.ChildIndexB;
            this.IsTouching = contact.IsTouching;
            this.IslandFlag = contact.IslandFlag;
            this.TOIFlag = contact.TOIFlag;
            this.FilterFlag = contact.FilterFlag;
            this.FixtureA = contact.FixtureA;
            this.FixtureB = contact.FixtureB;
            this._nodeA.Clone(contact._nodeA);
            this._nodeB.Clone(contact._nodeB);
            this.Manifold.LocalNormal = contact.Manifold.LocalNormal;
            this.Manifold.LocalPoint = contact.Manifold.LocalPoint;
            this.Manifold.PointCount = contact.Manifold.PointCount;
            for (int i = 0; i < contact.Manifold.PointCount; i++)
            {
                this.Manifold.Points[i] = contact.Manifold.Points[i];
            }
            this.Manifold.Type = contact.Manifold.Type;
        }

        public void Restore(TrueSync.Physics2D.Contact contact)
        {
            contact._type = this._type;
            contact._toiCount = this._toiCount;
            contact._toi = this._toi;
            contact.Friction = this.Friction;
            contact.Restitution = this.Restitution;
            contact.TangentSpeed = this.TangentSpeed;
            contact.Enabled = this.Enabled;
            contact.ChildIndexA = this.ChildIndexA;
            contact.ChildIndexB = this.ChildIndexB;
            contact.IsTouching = this.IsTouching;
            contact.IslandFlag = this.IslandFlag;
            contact.TOIFlag = this.TOIFlag;
            contact.FilterFlag = this.FilterFlag;
            contact.FixtureA = this.FixtureA;
            contact.FixtureB = this.FixtureB;
            contact.Manifold.LocalNormal = this.Manifold.LocalNormal;
            contact.Manifold.LocalPoint = this.Manifold.LocalPoint;
            contact.Manifold.PointCount = this.Manifold.PointCount;
            for (int i = 0; i < this.Manifold.PointCount; i++)
            {
                contact.Manifold.Points[i] = this.Manifold.Points[i];
            }
            contact.Manifold.Type = this.Manifold.Type;
        }

        public string Key
        {
            get
            {
                return (this.FixtureA.FixtureId + "_" + this.FixtureB.FixtureId);
            }
        }
    }
}

