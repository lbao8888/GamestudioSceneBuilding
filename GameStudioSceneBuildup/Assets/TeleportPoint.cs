using UnityEngine;

public class TeleportPoint : MonoBehaviour
{
    [Header("传送目标位置")]
    public Transform targetPoint;

    [Header("玩家标签")]
    public string playerTag = "Player";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerTag) && targetPoint != null)
        {
            other.transform.position = targetPoint.position;
        }
    }
}