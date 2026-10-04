export class Kata {
  static disemvowel(str: string): string {
    let newString: string = "";
    for (const char of str) {
      
      if (char.toLowerCase() == 'a' || 
          char.toLowerCase() == 'e' || 
          char.toLowerCase() == 'i' || 
          char.toLowerCase() == 'o' || 
          char.toLowerCase() == 'u') {
        
      }
      else {
        newString += char;
      }
    }
    return newString;
  }
}