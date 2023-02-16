using UnityEngine;
public class ShieldController : MonoBehaviour
{
    public MyGameController MGC;
    private Camera MainCam;
    public Transform Shield;
    void Start()
    {
        MainCam = Camera.main;
    }
    void Update()
    {
        if (MGC.MouseControls)
        {
            Vector3 mouse = Input.mousePosition;
            Vector3 ScreenPoint = MainCam.WorldToScreenPoint(transform.localPosition);
            Vector2 offset = new Vector2(mouse.x - ScreenPoint.x, mouse.y - ScreenPoint.y);
            float angle = Mathf.Atan2(offset.y, offset.x) * Mathf.Rad2Deg;
            Shield.rotation = Quaternion.Euler(0f, 0f, angle);
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
                Shield.rotation = Quaternion.Euler(0f, 0f, 90f);
            if (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S))
                Shield.rotation = Quaternion.Euler(0f, 0f, 270f);
            if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
                Shield.rotation = Quaternion.Euler(0f, 0f, 0f);
            if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
                Shield.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
    }
}
