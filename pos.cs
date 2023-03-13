using UdonSharp;
using UnityEngine;
using UnityEngine.UI;
using VRC.SDKBase;
using VRC.Udon;

public class pos : UdonSharpBehaviour
{
    [SerializeField] private GameObject target;
    [SerializeField] private Text targetText_pos;
    [SerializeField] private Text targetText_vel;

    private void Update()
    {   
        Vector3 posvec = target.transform.localPosition;
        Vector3 velvec = target.GetComponent<Rigidbody>().velocity;
        targetText_pos.text =   "pos:\n"
                        +   posvec.x.ToString() + "\n"
                        +   posvec.y.ToString() + "\n"
                        +   posvec.z.ToString();
        targetText_vel.text =   "vel:\n"
                        +   velvec.x.ToString() + "\n"
                        +   velvec.y.ToString() + "\n"
                        +   velvec.z.ToString();

    }
}