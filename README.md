# AsyncExecutor
AsyncExecutor for Unity
<br>
`async`는 없어서 못쓰고, 쓰레드 작업은 해야하고, 작업 시퀸스는 맞춰야 할 때

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
