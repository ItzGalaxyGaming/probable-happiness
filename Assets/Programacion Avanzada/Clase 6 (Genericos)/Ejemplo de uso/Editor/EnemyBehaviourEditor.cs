using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Clases.PA2024.Generics
{
    [CustomEditor(typeof(EnemyBehaviour))]
    public class EnemyBehaviourEditor : DamageableEditor<EnemyBehaviour> { }
}