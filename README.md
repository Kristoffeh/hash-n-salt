# hash n salt
 Will be used for securing login and registration system
 Fiddle: https://dotnetfiddle.net/yVeOVA

### What does it do?
* Takes a string.
* Uses SHA-256 to hash it.
* Adds a salt to the hash.
Poof, added 10 layers of security.

### How do i unhash it?
* Grab the old string.
* Grab the new string.
* Use the code below.

```csharp
PasswordHandler.Validate(text, hash);
```

Quick example:
```csharp
var validation = PasswordHandler.Validate(text, hash);

if (validation == true){
    MessageBox.Show("Login success!");
}
```
