# Blazor Resume

A personal resume site built with Blazor WebAssembly (.NET 9), deployed to GitHub Pages via GitHub Actions.

## Using this as a template

### 1. Fork the repository

Click **Fork** at the top-right of this page. Give it any name you like — if you name it `username.github.io` it will deploy to your root domain instead of a subdirectory.

### 2. Enable GitHub Pages

In your forked repo, go to **Settings → Pages → Build and deployment** and set the source to **GitHub Actions**.

### 3. Update the workflow base href

Open `.github/workflows/deploy.yml` and change the `base_href` value to match your repo name:

```yaml
- name: Rewrite base href
  uses: stevesandersonms/ghaction-rewrite-base-href@v1
  with:
    html_path: publish/wwwroot/index.html
    base_href: /your-repo-name/
```

If your repo is named `username.github.io`, use `base_href: /` instead.

Also update the redirect in `WilliamMulrine/wwwroot/404.html` to match:

```js
var base = location.protocol + '//' + location.host + '/your-repo-name/';
```

### 4. Edit your resume content

All resume content lives in a single file: `WilliamMulrine/MyResume.cs`. Edit it to replace the name, title, experience, skills, and other details. Every piece of visible text on the page comes from this file — no other files need to be touched for content changes.

### 5. Push to deploy

Commit and push to `main`. The GitHub Actions workflow builds and deploys automatically. Your site will be live at:

```
https://username.github.io/your-repo-name/
```

## Local development

Requires [.NET 9 SDK](https://dotnet.microsoft.com/download).

```bash
cd WilliamMulrine
dotnet watch
```
