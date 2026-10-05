export function isValidWalk(walk: string[]) {
  if (walk.length != 10) { 
    return false;}
  
  let north: number = 0;
  let south: number = 0;
  let east: number = 0;
  let west: number = 0;
​
  for (const direction of walk) {
    if (direction === 'n') {
      north++;
    }
    else if (direction === 's') {
      south++;
    }
    else if (direction === 'e') {
      east++;
    }
    else if (direction === 'w') {
      west++;
    }
  }
  
  if (north === south && east === west) {
    return true;
  }
  
  return false;
    
}