using System;
using UnityEngine;

public class EyeController : MonoBehaviour
{
    public Transform eye;

    public EyeState current;

    public void Start()
    {
        eye.rotation = Quaternion.Euler(current.position);
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var transition in current.transitions)
        {
            if (Input.GetKeyDown(transition.key))
            {
                eye.rotation = Quaternion.Euler(transition.state.position);
                current = transition.state;
                break;
            }
        }
    }
}
