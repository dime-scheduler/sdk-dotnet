module.exports = {
  title: 'Dime.Scheduler SDK',
  tagline: 'Dime.Scheduler Software Development Kit',
  url: 'https://sdk.dimescheduler.com',
  baseUrl: '/',
  onBrokenLinks: 'warn',
  onBrokenMarkdownLinks: 'warn',
  favicon: 'img/favicon.ico',
  organizationName: 'dime-scheduler',
  projectName: 'sdk-dotnet',
  themeConfig: {
    image: 'https://cdn.dimescheduler.com/dime-scheduler/og.png',    
    prism: {
      theme: require('prism-react-renderer/themes/github'),
      darkTheme: require('prism-react-renderer/themes/dracula'),
      additionalLanguages: ['csharp']
    },
    sidebar: {
      hideable: true
    },
    navbar: {
      hideOnScroll: true,
      title: 'Dime.Scheduler SDK',
      logo: {
        alt: 'Dime Logo',
        src: 'img/dime.png',
      },
      items: [
        {
          to: 'docs',
          label: 'Docs',
          position: 'left',
        },
        {
          to: 'docs/api/getting-started',
          label: 'API',
          position: 'left',
        },
        {
          href: 'https://github.com/dime-scheduler/sdk-dotnet',
          position: 'right',
          className: 'header-github-link',
          'aria-label': 'GitHub repository',
        }
      ],
    },
    footer: {
      style: 'dark',
      links: [
        {
          title: 'Docs',
          items: [
            {
              label: 'Getting started',
              to: 'docs/',
            },
            {
              label: 'Installation',
              to: 'docs/installation',
            },
            {
              label: 'Glossary',
              to: 'docs/glossary',
            }
          ],
        },
        {
          title: 'Deep dive',
          items: [
            {
              label: 'Import service',
              to: 'docs/import/import',
            },
            {
              label: 'GitHub',
              href: 'https://github.com/dime-scheduler/sdk-dotnet',
            },
            {
              label: 'Docs',
              href: 'https://docs.dimescheduler.com',
            },
          ]
        },
        {
          title: 'Social',
          items: [
            {
              label: 'Website',
              href: 'https://dimescheduler.com',
            },
            {
              label: 'LinkedIn',
              href: 'https://www.linkedin.com/company/dimesoftware',
            },
            {
              label: 'Twitter',
              href: 'https://twitter.com/dimesoftware',
            },
            {
              label: 'Facebook',
              href: 'https://www.facebook.com/dimesoftware',
            },
            {
              label: 'Youtube',
              href: 'https://www.youtube.com/channel/UCYD4LGox7SJLL7r8gmjulNA',
            }
          ]
        }
      ],
      logo: {
        alt: 'DS logo',
        src: 'img/ds-dark.png',
        href: 'https://dimescheduler.com',
      },
      copyright: `Copyright © ${new Date().getFullYear()} Dime Software.`,
    },
  },
  presets: [
    [
      '@docusaurus/preset-classic',
      {
        docs: {
          sidebarPath: require.resolve('./sidebars.js'),
          editUrl:
            'https://github.com/dime-scheduler/sdk-dotnet/edit/master/docs',
        },
        theme: {
          customCss: require.resolve('./src/css/custom.css'),
        },
      },
    ],
  ],
};
