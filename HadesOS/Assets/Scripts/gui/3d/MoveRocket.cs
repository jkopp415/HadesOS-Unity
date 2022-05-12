using gui;
using UnityEngine;

public class MoveRocket : MonoBehaviour
{
    DataPane dataPane;

    void Start()
    {
        dataPane = transform.parent.GetComponent<DataPane>();
    }

    void Update()
    {
        float rocketX = dataPane.bnoDataPane.GetEulerX();
        float rocketY = dataPane.bnoDataPane.GetEulerY();
        float rocketZ = dataPane.bnoDataPane.GetEulerZ();
        
        Quaternion target = Quaternion.Euler(rocketZ, rocketX, rocketY);
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * 5.0f);
    }
}
