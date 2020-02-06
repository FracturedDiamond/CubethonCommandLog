using UnityEngine;

class MoveLeft : Command
{
    Rigidbody m_rb;
    float m_sidewaysForce;

    public MoveLeft(Rigidbody rb, float sidewaysForce)
    {
        m_rb = rb;
        m_sidewaysForce = sidewaysForce;
    }

    public override void Execute()
    {
        // Add sideways force
        m_rb.AddForce(-m_sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
    }
}