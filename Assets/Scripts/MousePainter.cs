using UnityEngine;

public class MousePainter : MonoBehaviour{
    public Camera cam;
    [Space]
    public bool mouseSingleClick;
    [Space]
    public Color paintColor;
    [Space]
    public Transform target;
    
    public float radius = 1;
    public float strength = 1;
    public float hardness = 1;

    void Update(){

        // bool click;
        // click = mouseSingleClick ? Input.GetMouseButtonDown(0) : Input.GetMouseButton(0);

        // if (click){
            // Vector3 position = Input.mousePosition;
            // Ray ray = cam.ScreenPointToRay(position);
            Vector3 direction = target.transform.position - cam.transform.position;
            Ray ray = new Ray(cam.transform.position, direction);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, 100.0f)){
                Debug.DrawRay(ray.origin, hit.point - ray.origin, Color.red);
                transform.position = hit.point;
                Paintable p = hit.collider.GetComponent<Paintable>();
                if(p != null){
                    PaintManager.instance.paint(p, hit.point, radius, hardness, strength, paintColor);
                }
            }
        // }

    }

}
