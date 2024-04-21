import styles from "./styles.module.scss";

export function CardIndexComponent() {
    return(
        <div className={styles.principal}>
            <div className={styles.logoPrincipal}>
                <img src="./logo.jpg" className={styles.logo}/>
            </div>
            <br/>
            <div className={styles.cardVerde}>
                sad
            </div>
            <div className={styles.cardRoxo}>
                sad
            </div>
        </div>
    )
}