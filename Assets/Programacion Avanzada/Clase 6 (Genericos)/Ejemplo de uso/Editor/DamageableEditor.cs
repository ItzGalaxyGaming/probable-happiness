using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace Clases.PA2024.Generics
{
    public class DamageableEditor<T> : Editor where T : IDamageable
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            if (!Application.isPlaying) return;

            if (GUILayout.Button("Do Damage"))
            {
                (target as MonoBehaviour).GetComponent<IDamageable>().GetDamage();
            }
        }
    }
}
