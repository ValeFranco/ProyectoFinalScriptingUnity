using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.TestTools;

public class TestVictoria
{
    string nombreEscena = "Victoria";

    [SetUp]
    public void SetUp()
    {
        EditorSceneManager.LoadScene(nombreEscena);
    }
    [UnityTest]
    public IEnumerator TestVictoriaWithEnumeratorPasses()
    {
        GameObject player;
        player = GameObject.FindGameObjectWithTag("Player");
        Assert.IsNotNull(player);

        int playerOriginalPower = (int)player.GetComponent<ControlJugador>().jugador.poder;

        yield return new WaitForSeconds(1f);

        player.transform.position = new Vector2(-6.4f, -0.2f);

        yield return new WaitForSeconds(1f);

        player.transform.position = new Vector2(-4.3f, 0.0f);

        yield return new WaitForSeconds(2f);

        player.transform.position = new Vector2(1.2f, -3.1f);

        yield return new WaitForSeconds(2f);

        player.transform.position = new Vector2(1.4f, 0.1f);

        yield return new WaitForSeconds(2f);

        player.transform.position = new Vector2(1.2f, 2.8f);

        yield return new WaitForSeconds(1f);

        Assert.Greater(player.GetComponent<ControlJugador>().jugador.poder, playerOriginalPower);
    }
    public void Teardown()
    {
        EditorSceneManager.UnloadSceneAsync(nombreEscena);
    }
}
