using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Nez;

namespace Testris.Components
{
    public class DamageComponent : Component
    {
        SimpleMover _mover;

        private const float reducedSpeed = 70f;

        public override void onAddedToEntity()
        {
            _mover = this.entity.getComponent<SimpleMover>();

            Core.schedule(2f, t => takeDamageTwo());
        }

        public void takeDamage()
        {
            _mover.speed = reducedSpeed;

            Core.schedule(2f, t => _mover.speed = 100f);
        }

        public void takeDamageTwo()
        {
            _mover.speed = reducedSpeed;

            Core.startCoroutine(resetSpeedAfterDelay());
        }

        IEnumerator resetSpeedAfterDelay()
        {
            yield return Coroutine.waitForSeconds(2f);

            _mover.speed = 100f;
        }
    }
}
