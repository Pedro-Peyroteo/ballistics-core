# Ballistics Core

A headless, data-driven ballistic simulation core.

This project focuses on:

- clean mathematical primitives
- explicit physics state
- modular, compiler-style simulation rules
- engine-agnostic design

## Current state

- Custom `Vec3` math type (add, subtract, scale, magnitude, normalize)
- Verified via a CLI sanity harness
- Pure data `ProjectileState` (position, velocity)
- No engine, no rendering, no collisions yet

## Design principles

- Math and physics are explicit and readable
- State is data, behavior is applied separately
- Small, incremental steps over premature abstraction
- Everything should be portable and inspectable

This README is temporary and will evolve with the project.
