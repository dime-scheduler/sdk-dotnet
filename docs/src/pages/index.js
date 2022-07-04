import React from 'react';
import clsx from 'clsx';
import Layout from '@theme/Layout';
import Link from '@docusaurus/Link';
import useDocusaurusContext from '@docusaurus/useDocusaurusContext';
import useBaseUrl from '@docusaurus/useBaseUrl';
import styles from './styles.module.css';
import ImageCard from './imageCard';

const features = [
  {
    title: 'Connect to any system',
    imageUrl: 'img/integrate.svg',
    description: (
      <>
        Dime.Scheduler's flexibility allows for integration with any system. Connect your bespoke software and workflows with Dime.Scheduler and vice versa.
      </>
    ),
  },
  {
    title: 'Lightweight',
    imageUrl: 'img/coder.svg',
    description: (
      <>
        With a few lines of code, you can plug your application right into the core of Dime.Scheduler.
      </>
    ),
  },
  {
    title: 'Open source',
    imageUrl: 'img/progress.svg',
    description: (
      <>
        The SDK is open source and is free to use. It was made by developers, for developers.
      </>
    ),
  },
];

function OtherFeature({ imageUrl, title, description, i }) {
  const imgUrl = useBaseUrl(imageUrl);

  const offsetCls = "col--offset-2";
  const isImageRight = i % 2 == 0;

  const txtCls = `col col--5 padding-vert--xl ${!isImageRight ? offsetCls : ""}`;
  const txt = <div className={txtCls}>
    <h2>{title}</h2>
    <p className="featureDescription_2nlI">{description}</p>
  </div>;

  const imgCls = `col col--5 ${isImageRight ? offsetCls : ""}`;
  const img = <div className={imgCls}>
    <div className="featureImageColumn_QmtA">
      <img alt={title} src={imgUrl} style={{ height: "250px" }} />
    </div>
  </div>;

  const content = i % 2 == 0 ? [img, txt] : [txt, img];
  return (
    <div className="row">{content}</div>
  );
}

function Home() {
  const context = useDocusaurusContext();
  return (
    <Layout      
      description="Dime.Scheduler Software Development Kit">
      <header className={clsx('hero hero--primary heroTilted_3die', styles.heroBanner)}>
        <div className="container">
          <img src="img/ds.svg" width="500" alt="Dime.Scheduler logo" />
          <p className="hero__subtitle">Software Development Kit</p>
          <div className={styles.buttons}>
            <Link
              className={clsx(
                'button button--outline button--secondary button--lg',
                styles.getStarted,
              )}
              to={useBaseUrl('docs/')}>
              Get Started
            </Link>
          </div>
          <ImageCard image={"img/DS1.png"} className="center" style={{ paddingTop: "25px" }} />
        </div>
      </header>
      <main>

        {features && features.length > 0 && (
          <section className={styles.features}>
            <div className="container">
              <div className="row">
                {features.map((props, idx) => (
                  <OtherFeature key={idx} {...props} i={idx} />
                ))}
              </div>
            </div>
          </section>
        )}

   
      </main>
    </Layout >
  );
}

export default Home;
