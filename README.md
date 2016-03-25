# AsyncExecutor
AsyncExecutor for Unity

```c#
IEnumerator MyFunc() {
  Debug.Log("Before exe");
  
  yield return new AsyncExecutor(() => {
    // This job will be dispatched on worker-thread.
    VeryLongTask();
  });
  
  Debug.Log("After exe");
}
```
