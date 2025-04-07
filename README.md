# 🛠️ Backend Performance Optimization Exercise

## Overview

This exercise is designed to assess your ability to identify and resolve performance issues in a .NET Web API. You'll be working with an existing API endpoint that retrieves a user's order history. The problem is that it is poorly optimized.

Your task is to review the code and optimize it for performance while maintaining existing functionality.

---

## The Scenario

We've provided you with:
- A simple Web API project using ASP.NET Core.
- A SQL Server-compatible schema with `Users`, `Orders`, and `OrderItems`.
- An API endpoint: `GET /users/{id}/orders` that fetches a user’s orders and related order items.

---

### The Problem

This endpoint performs poorly (5+ seconds) when retrieving data for users with many orders.

Your job is to:
1. Identify the performance bottlenecks.
2. Optimize the code and/or schema to significantly improve performance.
3. Justify your approach and trade-offs.

---

## Tasks

1. Review the code live.
2. Suggest improvements. This can be done via your editor in code or you may walk us through how you would go about fixing this verbally.

---

## ✅ What We’re Looking For

- Clear problem-solving approach.
- Understanding of performance bottlenecks.
- Ability to explain and justify technical decisions.
