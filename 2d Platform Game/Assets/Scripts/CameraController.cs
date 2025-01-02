using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPositionX;
    private Vector3 velocity = Vector3.zero;

    //Follow player
    [SerializeField] private Transform player;

    private void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPositionX, transform.position.y, transform.position.z),
        //ref velocity, speed);

        //Follow player
        transform.position = new Vector3(player.position.x, transform.position.y, transform.position.z); 

    }

    public void MoveToNewRoom(Transform _newRoom)
    {
        currentPositionX = _newRoom.position.x;
    }
}
