using UnityEngine;

public class RotateGun : MonoBehaviour
{

    public GrapplingGun grappling;
    public MovingSphere movingSphere;

    private Quaternion desiredRotation;
    private float rotationSpeed = 5f;

    void Update()
    {
        if (!grappling.IsGrappling())
        {
            desiredRotation = Quaternion.LookRotation(movingSphere.forwardAxis, movingSphere.upAxis);
        }
        else
        {
            desiredRotation = Quaternion.LookRotation(grappling.GetGrapplePoint() - transform.position);
        }

        transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, Time.deltaTime * rotationSpeed);
    }

}
