
# Event Manager

Minecraft sunucularında bulunan Event sisteminin C# yazılım diline uyarlanmış bir hali. Bu sistemi istediğiniz her yerde kullanabilirsiniz. *(Örn: Oyunlar, Yönetim Uygulamarı, vb.)*
## Nasıl Kullanılır?

#### Dinleyici kaydetme

```csharp
EventManager.RegisterListener(<listener class>);
```

#### Dinleyici kaldırma

```csharp
EventManager.UnregisterListener(<listener class>);
```

#### Event çağırma

```csharp
EventManager.CallEvent(<event class>);
```
