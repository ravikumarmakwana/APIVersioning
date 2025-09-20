# 🚀 API Versioning in ASP.NET Core

This repository demonstrates **API Versioning strategies in ASP.NET Core** with working examples.  
Checkout Medium article 👉 [API Versioning Strategies in ASP.NET Core](https://medium.com/@ravikumar.makwana/api-versioning-strategies-in-asp-net-core-b066eb167b68).  

The goal is to understand **what versioning is, why it's needed, when to apply it, and how to implement it** using ASP.NET Core.  

---

## 📖 What is API Versioning?

As applications evolve, APIs often need changes — new fields, new endpoints, or improved behaviour. But existing clients (mobile, web, third-party apps) may rely on older versions.  
API Versioning solves this problem by allowing **multiple versions of APIs to coexist**. It ensures backward compatibility while letting you add improvements safely.

---

## 💡 Why API Versioning?

- ✅ **Backward compatibility** – existing clients don’t break  
- ✅ **Gradual migration** – consumers can adopt new versions at their pace  
- ✅ **Flexibility** – experiment with new features without affecting stable APIs  
- ✅ **Maintainability** – deprecate old versions gracefully  

**When to start versioning?**  
👉 As soon as your API is exposed to external consumers (e.g., mobile apps, partner integrations, public APIs).  
👉 Even if it’s internal, versioning helps when multiple teams consume the same API.

---

## 🛠 Strategies Demonstrated

This project covers **4 main API versioning strategies** supported in ASP.NET Core:

1. **URL Segment Versioning**  
   - Version is part of the route.  
   - Example:  
     ```
     GET /api/v1/Products
     GET /api/v2/Products
     ```

2. **Query String Versioning**  
   - Version passed as query param.  
   - Example:  
     ```
     GET /api/Products?api-version=1.0
     GET /api/Products?api-version=2.0
     ```

3. **Header Versioning**  
   - Version provided in custom request header.  
   - Example:  
     ```
     GET /api/Products
     X-API-VERSION: 2.0
     ```
     
4. **Media-Type Versioning**  
   - Version provided in Accept header.  
   - Example:  
     ```
     GET /api/Products
     Accept: application/json; version=2.0
     ```

