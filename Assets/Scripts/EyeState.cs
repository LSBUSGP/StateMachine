using System;
using UnityEngine;

[CreateAssetMenu]
public class EyeState : ScriptableObject
{
    [Serializable]
    public class Transition
    {
        public KeyCode key;
        public EyeState state;
    }

    public Vector3 position;
    public Transition[] transitions;
}
