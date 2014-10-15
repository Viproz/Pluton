﻿using System;

namespace Pluton.Events
{
    public class HurtEvent
    {
        private HitInfo _info;

        public HurtEvent(HitInfo info)
        {
            _info = info;
        }

        public float DamageAmount {
            get {
                return _info.damageAmount;
            }
        }

        public Rust.DamageType DamageType {
            get {
                return _info.damageType;
            }
        }

        public BaseEntity Attacker {
            get {
                return _info.Initiator;
            }
        }

        public InvItem Weapon {
            get {
                if (_info.Weapon == null)
                    return null;
                return new InvItem(_info.Weapon);
            }
        }
    }
}

