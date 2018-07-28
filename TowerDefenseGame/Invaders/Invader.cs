﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefenseGame
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        // Proteced only allows access from the Invader class & the subclasses.
        protected virtual int StepSize { get; } = 1;

        public virtual int Health { get; protected set; } = 2;

        public MapLocation Location => _path.GetLocationAt(_pathStep);

        public bool HasScored { get { return _pathStep >= _path.Length; } }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;
        }

        public void Move() => _pathStep += StepSize;

        public virtual void DecreaseHealth(int factor) => Health -= factor;
    }
}
