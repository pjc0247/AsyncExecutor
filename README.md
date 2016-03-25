# AsyncExecutor
AsyncExecutor for Unity

```c#
IEnumerator MyFunc() {
  Debug.Log("Before exe");
  
  yield return new AsyncExecutor(() => {
    VeryLongTask();
  });
  
  Debug.Log("After exe");
}
```
