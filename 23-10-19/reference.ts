import { interval, Subject } from 'rxjs';
import { multicast } from 'rxjs/operators';
 
const source = interval(500);
const subject = new Subject();
const multicasted = source.pipe(multicast(subject));
let subscription1, subscription2, subscriptionConnect;
 
subscription1 = multicasted.subscribe({
  next: (v) => console.log(`observerA: ${v}`)
});

subscriptionConnect = multicasted.connect();
 
setTimeout(() => {
  subscription2 = multicasted.subscribe({
    next: (v) => console.log(`observerB: ${v}`)
  });
}, 600);
 
setTimeout(() => {
  subscription1.unsubscribe();
}, 1200);
setTimeout(() => {
    subscription2.unsubscribe();
    subscriptionConnect.unsubscribe(); 
  }, 2000);