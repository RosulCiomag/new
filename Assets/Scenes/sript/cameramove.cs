using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class cameramove : MonoBehaviour
{
    public Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 v = Input.mousePosition;
        camera.transform.position = new Vector3(
            Mathf.Lerp(GameControler.transform.position.x, player.transform.position.x, 1f),
            player.transform.position.y,
            Mathf.Lerp(GameControler.transform.position.z, player.transform.position.z - 10f, 0.01f)
        );
    }
}
