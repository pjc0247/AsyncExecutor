# AsyncExecutor
AsyncExecutor for Unity
<br>
Provides yieldable asynchronous task. (alternative for `await`)

```c#
IEnumerator MyFunc() {
  Debug.Log("Before exe");
  
  int result = 0;
  yield return new AsyncExecutor(() => {
    // This job will be dispatched on worker-thread.
    result = VeryLongTask();
  });
  
  Debug.Log("After exe");
}
```
