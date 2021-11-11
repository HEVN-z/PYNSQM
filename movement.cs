//player movement
using UnityEngine;
using System.Collections;
plblic void Update ()
{
    if (Input.GetKey(KeyCode.W))
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.S))
    {
        transform.Translate(Vector3.back * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.A))
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
    if (Input.GetKey(KeyCode.D))
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}
void gunfire()
{
    GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation) as GameObject;
    bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
    Destroy(bullet, 2.0f);
}