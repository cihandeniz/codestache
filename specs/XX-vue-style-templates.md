# Vue Style Templates

Every template can consist of transformation, schema and template This is kinda
against the basic rule that says every template should be a valid syntax for
target language, but still, let's keep it for consideration.

```
<transform lang="javascript">
... some transformation javascript logic
</transform>
<schema>
model = {
  Service: [
  ]
};
</schema>
<template>
// #Service
public interface I_ServiceName_
{
  // #Method
  _ReturnType.FullName_ _Name_(/* #Parameters, */_ParameterType.FullName_ _name_/* / */);
  // /
}
// /
</template>
```
