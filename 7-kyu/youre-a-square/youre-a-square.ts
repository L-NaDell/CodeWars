export default function isSquare(n: number): boolean {
  const result = n ** 0.5;
  return result % 1 == 0;
};
​