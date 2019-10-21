import { Observable } from 'rxjs';
 
const foo = new Observable(subscriber => {
  console.log('Hello');
  subscriber.next(42);
  subscriber.next(100); 
  subscriber.next(200); 
});
 
console.log('before');
foo.subscribe(x => {
  console.log(x);
});
console.log('after')


