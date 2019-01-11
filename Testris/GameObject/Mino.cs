using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nez;
using Nez.Sprites;

namespace Testris.GameObject
{
    public class Mino : Component
    {
        private Sprite _sprite { get; set; }

        public virtual void onAddedToEntity()
        {
            _sprite = entity.getComponent<Sprite>();
        }
    }
}
