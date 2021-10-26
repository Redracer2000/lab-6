using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Prototype.MonsterSpawner
{
    public class SpawnController : MonoBehaviour
    {
        private Ghost ghostPrototype;
        private Demon demonPrototype;
        private Sorcerer sorcererPrototype;

        private Spawner[] monsterSpawners;


        void Start()
        {
            ghostPrototype = new Ghost(15, 3);
            demonPrototype = new Demon(11, 7);
            sorcererPrototype = new Sorcerer(4, 11);

            monsterSpawners = new Spawner[] {
                new Spawner(ghostPrototype),
                new Spawner(demonPrototype),
                new Spawner(sorcererPrototype)
            };

        }


        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //If we know which spawner we are using we can easily cast to the correct monster type
                Spawner ghostSpawner = new Spawner(ghostPrototype);

                Ghost newGhost = ghostSpawner.SpawnMonster() as Ghost;

                newGhost.Talk();
            }
        }
    }
}
