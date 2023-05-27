using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Physics : MonoBehaviour
{

    #region Variables

    [SerializeField] private float Gravity = 9.8f;
    [SerializeField] private float DistanceBoardPlayer = 6.4f;
    [SerializeField] private float DistanceTorusPlayer = 5.8f;
    [SerializeField] private float Mass = 0.567f;
    [SerializeField] private float MaxTimeHeight = 1.3f;
    [SerializeField] private float Restitution = 0.7f;
    [SerializeField] private Vector3 UpPosition = new Vector3(0,0,0);
    [SerializeField] private GameObject Ballon;
    [SerializeField]float Counter = 0;
    [SerializeField]bool Velocy = false;
    [SerializeField]float VelocityBallon = -2.34703f;

    #endregion



    #region Unity_Methods


    void Start(){
        UpPosition.y = (VelocityBallon) * -1;
        UpPosition.x = VelocityBallon;
    }


    void FixedUpdate(){
        if (Velocy)
        {
            Counter+= 0.01f;
            if (Counter >= 1.3f)
            {
                UpPosition.y *= -1;
            }
            Velocity();
        }
    }
    

    void Awake(){
        
    }


    #endregion



    #region My_Methods
    
    void Velocity(){
        Ballon.transform.position += UpPosition;
    }

    [ContextMenu("Velocity")]
    private void Holi() {
        Velocy=true;
    }

    #endregion


}
